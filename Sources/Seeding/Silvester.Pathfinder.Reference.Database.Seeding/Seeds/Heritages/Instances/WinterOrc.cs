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
    public class WinterOrc : Template
    {
        public static readonly Guid ID = Guid.Parse("9dba1e16-7728-473a-ac33-6d41275ac5c9");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Winter Orc"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("742d6404-5540-40ae-984e-d6d7232a2529"), Type = TextBlockType.Text, Text = "Your ancestors survived in cold climates. You become trained in Survival, and you treat environmental cold effects as if they were one step less extreme (incredible cold becomes extreme, extreme cold becomes severe, and so on)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("908a4f9f-54a1-47bb-bb47-2043999e78c6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.ModifyTemperature(Guid.Parse("90069fcf-5912-4404-9c93-d4810cb38dd0"), Temperature.Cold, ModifierType.Subtract, modifier: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("516777f7-b41f-4ffe-b6fe-0127643ed4de"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 50
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Orc.ID;
        }
    }
}
