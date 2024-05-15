using OWML.Common;
using OWML.ModHelper;

namespace OW_Euskaraz_Mod
{
    public class OW_Euskaraz_Mod : ModBehaviour
    {
        private void Awake()
        {
            // You won't be able to access OWML's mod helper in Awake.
            // So you probably don't want to do anything here.
            // Use Start() instead.
        }

        private void Start()
        {
            // Starting here, you'll have access to OWML's mod helper.
            ModHelper.Console.WriteLine($"{nameof(BasqueTranslation)} is loaded!", MessageType.Success);

            var api = ModHelper.Interaction.TryGetModApi<ILocalizationAPI>("xen.LocalizationUtility");
            api.RegisterLanguage(this, "Euskara", "assets/Translation.xml");
        }
    }

}
