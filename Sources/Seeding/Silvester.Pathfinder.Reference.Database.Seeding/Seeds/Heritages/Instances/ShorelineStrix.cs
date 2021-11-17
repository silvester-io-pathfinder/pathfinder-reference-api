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
    public class ShorelineStrix : Template
    {
        public static readonly Guid ID = Guid.Parse("4addd262-d258-4689-b017-8809d2aa0206");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Shoreline Strix"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4ebf036c-98bd-462c-b49e-8a68360dc6fc"), Type = TextBlockType.Text, Text = "You're the descendant of strix who traveled to the coasts. Your feathers are especially water-repellent and sleekly angled for diving, allowing you to catch fish and other prey in the shallows. You are trained in Athletics, and you gain the Underwater Marauder skill feat as a bonus skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("6e713a0d-50aa-4c25-ad3b-8dfe5c58560b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
            builder.GainSpecificFeat(Guid.Parse("f78e88d4-65f4-46f1-a4e6-92c7b59d4dd1"), Feats.Instances.UnderwaterMarauder.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cfbda40a-167c-45fd-82ed-25c79032d677"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 135
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Strix.ID;
        }
    }
}
