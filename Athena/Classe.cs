/**
 * Ce fichier définit la classe Classe qui représente une classe d'élèves.
 * Elle contient des propriétés pour le nom de la classe et des constructeurs pour initialiser ces propriétés.
 */

using System;

namespace CartesAcces2024
{
    public class Classe
    {
        // Propriété pour le nom de la classe
        public string Classes { get; set; }

        // Constructeur par défaut
        public Classe()
        {
            Classes = "null"; // Initialisation par défaut
        }

        // Constructeur avec un paramètre pour le nom de la classe
        public Classe(string nomClasse)
        {
            Classes = nomClasse; // Initialisation avec le nom de la classe fourni
        }
    }
}

/**
 * MIT License
 * 
 * Copyright (c) 2023, 2024 Collège Caroline Aigle
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
