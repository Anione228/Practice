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
            themehDTO.Hello.ForeColor = Color.White;
            themehDTO.Name.ForeColor = Color.White;
        }
        public void ChangeLightTheme(HomeThemeDTO themehDTO)
        {
            themehDTO.Hello.ForeColor = Color.Black;
            themehDTO.Name.ForeColor = Color.Black;
        }
    }
}
