using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VibrantDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("886e59c1-d94b-4f72-86db-418cab9ad1b2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vibrant Display",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once every 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e1289105-9725-4c48-aab8-6034dc33fd7a"), Type = TextBlockType.Text, Text = "Whereas most gnomes’ coloration is static or changes slowly, you can cause your hair, eye, and skin color to scintillate in brief and disorienting bursts. Once every 10 minutes, when you use the (action: Feint) action, you can compare your Deception check result to the Perception DCs of all adjacent creatures rather than just one creature within melee reach. It’s possible to get a different degree of success for each target." };
            yield return new TextBlock { Id = Guid.Parse("acf25e7e-5aac-4f68-a1f0-847939d2c07a"), Type = TextBlockType.Text, Text = "These changes are imprecise and usually short-lived, so while they allow you to periodically change your appearance in unpredictable ways, they are of little use in providing camouflage or aiding a disguise." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("e89230de-86be-4a4a-87af-f328af56b27f"), Heritages.Instances.ChameleonGnome.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf0f3331-494e-404a-9308-3395603a1e57"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
