using Word = Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;
using System.ComponentModel;
using ZXing;
using ZXing.Common;
using System.Drawing;
using System.Drawing.Imaging;

namespace CartesAcces2024
{
    public class EditionCodeBarre
    {
        private static List<string> cheminsImagesTemp = new List<string>();

        public static void GenererCodesBarres(List<string> codes, BackgroundWorker worker)
        {
            cheminsImagesTemp.Clear();
            int total = codes.Count;
            int progress = 0;

            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Width = 250,
                    Height = 80,
                    Margin = 2,
                    PureBarcode = true
                }
            };

            foreach (string code in codes)
            {
                if (worker.CancellationPending)
                    return;

                try
                {
                    using (Bitmap completeBitmap = new Bitmap(250, 120))
                    using (Graphics g = Graphics.FromImage(completeBitmap))
                    {
                        g.FillRectangle(Brushes.White, 0, 0, completeBitmap.Width, completeBitmap.Height);

                        using (Bitmap barcodeBitmap = writer.Write(code))
                        {
                            g.DrawImage(barcodeBitmap, 0, 0);
                        }

                        using (Font font = new Font("Arial", 10))
                        {
                            SizeF textSize = g.MeasureString(code, font);
                            PointF textPosition = new PointF(
                                (completeBitmap.Width - textSize.Width) / 2,
                                90
                            );

                            g.DrawString(code, font, Brushes.Black, textPosition);
                        }

                        string tempImagePath = System.IO.Path.GetTempFileName() + ".png";
                        completeBitmap.Save(tempImagePath, ImageFormat.Png);
                        cheminsImagesTemp.Add(tempImagePath);
                    }

                    progress++;
                    worker.ReportProgress((int)((double)progress / total * 100));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la génération du code-barre: {ex.Message}");
                }
            }
        }

        ///// <summary>
        ///// Génère un code barre à partir d'un texte et le renvoie sous forme de BitMap.
        ///// </summary>
        ///// <param name="unTexte"></param>
        ///// <returns></returns>
        //public static Bitmap GenererUnCodeBarreEnBitmap(string unTexte)
        //{
        //    IBarcodeWriterPixelData encodeurCodeBarre = new BarcodeWriterPixelData()  // pour lire le code barre
        //    { 
        //        Format = BarcodeFormat.CODE_128 // On doit spécifier le format, sinon le format est  et ce format est invalide (lève un exception)
        //    };
        //    Bitmap rtrn = encodeurCodeBarre.Write(unTexte).ToBitmap(); // on encode le texte et le converti en bitmap
        //    return rtrn;
        //}

        /// <summary>
        /// Encode le texte en paramètre dans la picturebox passée en paramètre.
        /// </summary>
        /// <param name="texte"></param>
        /// <param name="pictureBox"></param>
        public static void AfficherCodeBarre(string texte, PictureBox pictureBox)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Width = 250,
                    Height = 80,
                    Margin = 2,
                    PureBarcode = true
                }
            };

            texte = RemoveAccents(texte);
            if (texte.Length <= 48)
            {
                using (Bitmap barcodeBitmap = writer.Write(texte))
                //using (Bitmap completeBitmap = new Bitmap(250, 120))
                using (Bitmap completeBitmap = new Bitmap(barcodeBitmap.Width + 20, barcodeBitmap.Height + 20))
                using (Graphics g = Graphics.FromImage(completeBitmap))
                {
                    g.FillRectangle(Brushes.White, 0, 0, completeBitmap.Width, completeBitmap.Height);
                    g.DrawImage(barcodeBitmap, 10, 10);

                    // permet de'écrire le texte en dessous du code barre
                    //using (Font font = new Font("Arial", 10))
                    //{
                    //    SizeF textSize = g.MeasureString(texte, font);
                    //    PointF textPosition = new PointF(
                    //        (completeBitmap.Width - textSize.Width) / 2,
                    //        90
                    //    );
                    //    g.DrawString(texte, font, Brushes.Black, textPosition);
                    //}

                    pictureBox.Height = completeBitmap.Height;
                    pictureBox.Width = completeBitmap.Width;
                    pictureBox.Image?.Dispose();
                    pictureBox.Image = new Bitmap(completeBitmap);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else
            {
                MessageBox.Show("La limite de caractères pour un code barre est 48 caractères.");
                pictureBox.Height = 180;
                pictureBox.Width = 180;
                pictureBox.Image?.Dispose();
                pictureBox.Image = new Bitmap(Image.FromFile(Chemin.CheminPhotoDefault));
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        /// <summary>
        /// Encode le texte passé en paramètre en code barre, et en renvoie le bitmap.
        /// </summary>
        public static Bitmap generrerBitMapDeCodeBarre(string texte)
        {

            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Width = (int)(250),
                    Height = (int)(80),
                    Margin = 2,
                    PureBarcode = true
                }
            };

            texte = RemoveAccents(texte);
            if (texte.Length <= 48)
            {
                using (Bitmap barcodeBitmap = writer.Write(texte))
                {
                    // Create the complete bitmap without a using statement since we're returning it
                    Bitmap completeBitmap = new Bitmap(barcodeBitmap.Width + 20, barcodeBitmap.Height + 20);
                    using (Graphics g = Graphics.FromImage(completeBitmap))
                    {
                        g.FillRectangle(Brushes.White, 0, 0, completeBitmap.Width, completeBitmap.Height);
                        g.DrawImage(barcodeBitmap, 10, 10);
                    }
                    return completeBitmap;
                }
            }
            else
            {
                MessageBox.Show("La limite de charactères pour un code barre est 48 caractères.");
                return new Bitmap(Image.FromFile(Chemin.CheminPhotoDefault));
            }
        }


        public static void SauvegarderPdfCodeBarres(string cheminDestination, BackgroundWorker worker)
        {
            Word.Application wordApp = null;
            Word.Document doc = null;

            try
            {
                wordApp = new Word.Application { Visible = false };
                doc = wordApp.Documents.Add();

                ConfigurePageMargins(doc, wordApp);

                int rows = (int)Math.Ceiling(cheminsImagesTemp.Count / 3.0);
                Word.Table table = doc.Tables.Add(doc.Range(0, 0), rows, 3);
                table.Borders.Enable = 0;

                int total = cheminsImagesTemp.Count;
                for (int i = 0; i < total; i++)
                {
                    if (worker.CancellationPending)
                    {
                        return;
                    }

                    int row = (i / 3) + 1;
                    int col = (i % 3) + 1;

                    Word.Cell cell = table.Cell(row, col);
                    Word.Range cellRange = cell.Range;
                    cellRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                    InsertBarcodeImage(cellRange, cheminsImagesTemp[i]);

                    worker.ReportProgress((int)((double)(i + 1) / total * 100));
                }

                doc.SaveAs2(cheminDestination, Word.WdSaveFormat.wdFormatPDF);
            }
            finally
            {
                CleanUpResources(doc, wordApp);
                // Nettoyer les fichiers temporaires
                foreach (string tempFile in cheminsImagesTemp)
                {
                    if (System.IO.File.Exists(tempFile))
                    {
                        try
                        {
                            System.IO.File.Delete(tempFile);
                        }
                        catch { }
                    }
                }
                cheminsImagesTemp.Clear();
            }
        }

        private static void ConfigurePageMargins(Word.Document doc, Word.Application wordApp)
        {
            float margin = wordApp.CentimetersToPoints(1.5f);
            doc.PageSetup.TopMargin = margin;
            doc.PageSetup.BottomMargin = margin;
            doc.PageSetup.LeftMargin = margin;
            doc.PageSetup.RightMargin = margin;
        }

        private static void InsertBarcodesIntoTable(List<string> codesBarres, Word.Table table)
        {
            int currentRow = 1;
            int currentCol = 1;

            foreach (string code in codesBarres)
            {
                Word.Cell cell = table.Cell(currentRow, currentCol);
                Word.Range cellRange = cell.Range;

                try
                {
                    string cleanCode = RemoveAccents(code);
                    InsererCodeBarre(cleanCode, cellRange);

                    // Mise à jour des positions dans la table
                    if (currentCol == 2)
                    {
                        currentCol = 1;
                        currentRow++;
                    }
                    else
                    {
                        currentCol++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la génération du code-barre: {ex.Message}");
                    continue;
                }
            }
        }

        private static void CleanUpResources(Word.Document doc, Word.Application wordApp)
        {
            if (doc != null)
            {
                doc.Close(false);
                Marshal.ReleaseComObject(doc);
            }
            if (wordApp != null)
            {
                wordApp.Quit();
                Marshal.ReleaseComObject(wordApp);
            }
        }

        private static void InsererCodeBarre(string code, Word.Range cellRange)
        {
            try
            {
                // Configuration du code-barre
                // No longer needed as we're using ZXing

                // Générer et sauvegarder temporairement l'image
                string tempImagePath = System.IO.Path.GetTempFileName() + ".png";
                // No longer needed as we're using ZXing

                if (!System.IO.File.Exists(tempImagePath))
                {
                    throw new Exception("Échec de la création du fichier image temporaire");
                }

                try
                {
                    // Centrer le paragraphe avant d'insérer l'image
                    cellRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    
                    // Insérer l'image dans Word
                    InsertBarcodeImage(cellRange, tempImagePath);
                }
                finally
                {
                    // Nettoyer le fichier temporaire
                    if (System.IO.File.Exists(tempImagePath))
                    {
                        System.IO.File.Delete(tempImagePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la génération du code-barre: {ex.Message}");
            }
        }

        private static void InsertBarcodeImage(Word.Range cellRange, string tempImagePath)
        {
            Word.InlineShape shape = cellRange.InlineShapes.AddPicture(tempImagePath);
            shape.Width = 120;
            shape.Height = 60;

            cellRange.InsertParagraphAfter();
            cellRange.Paragraphs[1].SpaceAfter = 0;
            cellRange.Paragraphs[1].SpaceBefore = 40;

            cellRange.Cells[1].LeftPadding = 25;
            cellRange.Cells[1].RightPadding = 25;
        }

        private static string RemoveAccents(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder normalizedString = new StringBuilder();
            foreach (char c in input)
            {
                switch (c)
                {
                    case 'É': normalizedString.Append('E'); break;
                    case 'È': normalizedString.Append('E'); break;
                    case 'Ê': normalizedString.Append('E'); break;
                    case 'Ë': normalizedString.Append('E'); break;
                    case 'À': normalizedString.Append('A'); break;
                    case 'Â': normalizedString.Append('A'); break;
                    case 'Ä': normalizedString.Append('A'); break;
                    case 'Î': normalizedString.Append('I'); break;
                    case 'Ï': normalizedString.Append('I'); break;
                    case 'Ô': normalizedString.Append('O'); break;
                    case 'Ö': normalizedString.Append('O'); break;
                    case 'Ù': normalizedString.Append('U'); break;
                    case 'Û': normalizedString.Append('U'); break;
                    case 'Ü': normalizedString.Append('U'); break;
                    case 'Ç': normalizedString.Append('C'); break;

                    case 'é': normalizedString.Append('e'); break;
                    case 'è': normalizedString.Append('e'); break;
                    case 'ê': normalizedString.Append('e'); break;
                    case 'ë': normalizedString.Append('e'); break;
                    case 'à': normalizedString.Append('a'); break;
                    case 'â': normalizedString.Append('a'); break;
                    case 'ä': normalizedString.Append('a'); break;
                    case 'î': normalizedString.Append('i'); break;
                    case 'ï': normalizedString.Append('i'); break;
                    case 'ô': normalizedString.Append('o'); break;
                    case 'ö': normalizedString.Append('o'); break;
                    case 'ù': normalizedString.Append('u'); break;
                    case 'û': normalizedString.Append('u'); break;
                    case 'ü': normalizedString.Append('u'); break;
                    case 'ç': normalizedString.Append('c'); break;

                    case '-': normalizedString.Append(' '); break;
                    
                    default: normalizedString.Append(c); break;
                }
            }
            return normalizedString.ToString();
        }
    }
}