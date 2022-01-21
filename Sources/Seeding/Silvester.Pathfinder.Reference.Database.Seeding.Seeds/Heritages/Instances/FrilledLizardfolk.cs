using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class FrilledLizardfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("9f93e0ae-57c0-4d13-9350-026e0d48bbbc");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Frilled Lizardfolk"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ba2525af-e608-4d86-8705-84fd2a0ff9e9"), Type = TextBlockType.Text, Text = "You can flare your neck frill and flex your dorsal spines, Demoralizing your foes. When you do, Demoralize loses the auditory trait and gains the visual trait, and you don't take a penalty when you attempt to Demoralize a creature that doesn't understand your language. You also gain the Threatening Approach action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("c44cfd82-5412-490b-b086-f9e23704b62e"), "You can flare your neck frill and flex your dorsal spines, Demoralizing your foes. When you do, Demoralize loses the auditory trait and gains the visual trait, and you don't take a penalty when you attempt to Demoralize a creature that doesn't understand your language.");
            builder.GainSpecificFeat(Guid.Parse("ff8dd72a-e3a4-430c-bec2-7ce6d36d6575"), Feats.Instances.ThreateningApproach.ID);

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46651c4e-525a-48d5-9ca5-8fc2dca015cb"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 57
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Lizardfolk.ID;
        }
    }
}
