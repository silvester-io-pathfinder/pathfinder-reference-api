using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class SweetbreathGnoll : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Sweetbreath Gnoll"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You're a striped, pale-furred gnoll with oddly pleasant breath, which you can use to entrance your prey. You are trained in Diplomacy (or another skill if you were already trained in Diplomacy). You also gain a +1 circumstance bonus to checks to Make an Impression if the target can smell your breath." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
                or.GainAnySkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse(""), prerequisites =>
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
                    });
            });

            builder.GainSpecificSkillActionCircumstanceBonus(Guid.Parse(""), SkillActions.Instances.MakeAnImpression.ID, bonus: 1, addendum: "If the target can smell your breath.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 111
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Gnoll.ID;
        }
    }
}
