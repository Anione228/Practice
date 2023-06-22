using Prcatice.DTO;
using System.Drawing;

namespace Prcatice.UI
{
    public class Themes
    {
        public void ChangeDarkTheme(OptionsThemeDTO themeDTO)
        {
            themeDTO.optionLabel.ForeColor = Color.White;
            themeDTO.themeLabel.ForeColor = Color.White;
            themeDTO.unitLadel.ForeColor = Color.White;

            themeDTO.radioButtonLight.ForeColor = Color.White;
            themeDTO.radioButtonDark.ForeColor = Color.White;
            themeDTO.radioButtonKm.ForeColor = Color.White;
            themeDTO.radioButtonFt.ForeColor = Color.White;
            
        }
        public void ChangeLightTheme(OptionsThemeDTO themeDTO)
		{
            themeDTO.optionLabel.ForeColor = Color.Black;
            themeDTO.themeLabel.ForeColor = Color.Black;
            themeDTO.unitLadel.ForeColor = Color.Black;

            themeDTO.radioButtonLight.ForeColor = Color.Black;
            themeDTO.radioButtonDark.ForeColor = Color.Black;
            themeDTO.radioButtonKm.ForeColor = Color.Black;
            themeDTO.radioButtonFt.ForeColor = Color.Black;
        }
        public void ChangeDarkTheme(HomeThemeDTO themehDTO)
        {
            themehDTO.helloText.ForeColor = Color.White;
            themehDTO.nameText.ForeColor = Color.White;
        }
        public void ChangeLightTheme(HomeThemeDTO themehDTO)
        {
            themehDTO.helloText.ForeColor = Color.Black;
            themehDTO.nameText.ForeColor = Color.Black;

        }
        public void ChangeDarkTheme(FaQThemeDTO FthemeDTO)
        {
            FthemeDTO.FaQLabel.ForeColor = Color.White;
        }
        public void ChangeLightTheme(FaQThemeDTO FthemeDTO)
        {

            FthemeDTO.FaQLabel.ForeColor = Color.Black;
        }
        public void ChangeDarkTheme(MainThemeDTO MthemeDTO)
        {
            
            MthemeDTO.playB.ForeColor = Color.White;
            MthemeDTO.faqB.ForeColor = Color.White;
            MthemeDTO.opB.ForeColor = Color.White;
            MthemeDTO.exitB.ForeColor = Color.White;
        }
        public void ChangeLightTheme(MainThemeDTO MthemeDTO)
        {
            MthemeDTO.playB.ForeColor = Color.Black;
            MthemeDTO.faqB.ForeColor = Color.Black;
            MthemeDTO.opB.ForeColor = Color.Black   ;
            MthemeDTO.exitB.ForeColor = Color.Black;
        }

    }
}
