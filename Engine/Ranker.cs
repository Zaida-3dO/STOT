﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Engine
{
    /// <summary>
    /// Author Timi
    /// Gets Results to the Query and ranks them by relevance.
    /// </summary>
    public static class Ranker
    {
        /// <summary>
        /// Searches the query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="Results">The results.</param>
        /// <returns> A list of documents in descending order of relevance</returns>
        public static List<Document> SearchQuery(List<String> query, Dictionary<Document,int[]> Results) {

            return null;
        }
        private static double TfWeight(int count) {
            if (count == 0)
                return 0;
            else
                return (1 + Math.Log(count));
        }
        private static double IDFWeight(int noOfDocuments) {
            return Math.Log(Inverter.Table.)
        }
    }
}
