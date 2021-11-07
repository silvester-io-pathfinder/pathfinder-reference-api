using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SoulArsenal : Template
    {
        public static readonly Guid ID = Guid.Parse("9641a8d9-2c33-43c6-981a-608a6229f9d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soul Arsenal",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat a second time at 12th level or higher, choosing the final item type.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b69e9b97-c966-4508-a70e-0f094989e5fe"), Type = TextBlockType.Text, Text = "Choose an additional soulforged armament of a different type than the type you already chose, and choose one essence power for it. Upgrade and change armaments individually." };
            yield return new TextBlock { Id = Guid.Parse("875a9f1d-3791-4fc6-a796-e7a41d90d803"), Type = TextBlockType.Text, Text = "When you Manifest Soulforged Armament, you can summon any number of your armaments (you must meet the Requirements for each), and when you (action: Dismiss) the effect, you can choose to (action: Dismiss) some and not others. You can choose to manifest the essence form of any number of your armaments when you take the action. Each armament can manifest its essence form only once per day." };
            yield return new TextBlock { Id = Guid.Parse("c5f20879-d449-4550-91a6-3f05754280b9"), Type = TextBlockType.Text, Text = "When you gain soulforged corruption, choose one armament’s corruption flaw to affect you for stage 1. At stage 2, you take the flaws of all your soulforged armaments. While you have the curse, each armament gets a separate flat check to manifest its essence form, and failing prevents you from manifesting only that armament’s essence form." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("085932a2-3005-4a50-88ec-43da1c340b2e"), Feats.Instances.ManifestSoulforgedArmament.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0ed4e95-9d1a-46ca-b256-0551e5b9e819"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
