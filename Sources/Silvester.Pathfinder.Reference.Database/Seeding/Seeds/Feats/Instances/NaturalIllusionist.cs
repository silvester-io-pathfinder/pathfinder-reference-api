using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NaturalIllusionist : Template
    {
        public static readonly Guid ID = Guid.Parse("79284d90-6bfe-457a-b4d1-56f6a84cc621");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Natural Illusionist",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5b3264b0-155d-4b1d-babd-b5810345557e"), Type = TextBlockType.Text, Text = "By drawing upon the First World’s magic, you can siphon a portion of that malleable world to create a convincing illusion. Once per day, you can cast (spell: illusory disguise), (spell: item facade), or (spell: ventriloquism). At 7th level, the spell is heightened to 2nd level, and every 2 levels thereafter, the spell is heightened an additional spell level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("be90b26a-cca5-4943-8faf-e27dabfb4074"), Feats.Instances.IllusionSense.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ac4caf1-50b9-423b-be13-21f0b400133b"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
