using System;
using System.Windows.Forms;

namespace TestTaskApp.Helpers
{
    public static class ErrorLog
    {
        /// <summary>
        /// Logging custom error message text
        /// </summary>
        /// <param name="errorMessage">Message Text</param>
        public static bool Log(string errorMessage)
        {
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                // Showing Message instead of writing in file :(
                MessageBox.Show(errorMessage, "Error");
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Logging common exception
        /// </summary>
        /// <param name="ex">Common exception</param>
        public static bool Log(Exception ex)
        {
            if (ex != null)
            {
                // Showing Message instead of writing in file :(
                MessageBox.Show($"({ex.Source}): {ex.Message}", "Error");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
