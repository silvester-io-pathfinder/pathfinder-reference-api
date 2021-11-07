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
    public class ShadowRat : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Shadow Rat"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your ancestors lived in dark spaces underground, granting you dark fur and a vaguely unnatural mien that unnerves sapient creatures and frightens animals. You gain the trained proficiency rank in Intimidation and can use Intimidation to Coerce animals. When you Demoralize an animal, you don’t take a penalty for not sharing a language with it. If you would automatically become trained in Intimidation (from your background or class, for example), you become trained in another skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Animals’ attitudes toward you begin one degree worse than normal, usually starting at unfriendly instead of indifferent for domesticated animals, and hostile instead of unfriendly for wild animals." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
                or.GainAnySkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse(""), prerequisites =>
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
                    });
            });
            builder.Manual(Guid.Parse(""), "You can use Intimidation to Coerce animals.");
            builder.Manual(Guid.Parse(""), "When you Demoralize an animal, you don’t take a penalty for not sharing a language with it.");
            builder.Manual(Guid.Parse(""), "Animals’ attitudes toward you begin one degree worse than normal, usually starting at unfriendly instead of indifferent for domesticated animals, and hostile instead of unfriendly for wild animals.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 22
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Ratfolk.ID;
        }
    }
}
