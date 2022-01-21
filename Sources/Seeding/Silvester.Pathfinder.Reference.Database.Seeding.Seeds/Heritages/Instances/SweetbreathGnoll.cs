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
        public static readonly Guid ID = Guid.Parse("bcdf0c58-bace-48a1-8465-088a15121252");

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
            yield return new TextBlock { Id = Guid.Parse("63d7e64e-4b7e-4dcc-8ae2-d30417a8d985"), Type = TextBlockType.Text, Text = "You're a striped, pale-furred gnoll with oddly pleasant breath, which you can use to entrance your prey. You are trained in Diplomacy (or another skill if you were already trained in Diplomacy). You also gain a +1 circumstance bonus to checks to Make an Impression if the target can smell your breath." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("399789b1-409b-4af6-a3ae-c3d24fdf4eea"), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse("de65cdec-71ef-4ab4-ac0d-94c765e2a4e9"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
                or.GainAnySkillProficiency(Guid.Parse("a39f3ef1-f7d3-4662-a749-93f2f0bc0939"), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse("194935eb-a98f-44ee-9835-eb12ffa68696"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse("ce01e165-a9d8-4a88-903f-2a1250dfdda8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
                    });
            });

            builder.GainSpecificSkillActionCircumstanceBonus(Guid.Parse("35ff9e94-df99-46bd-840b-badd2d635d5e"), SkillActions.Instances.MakeAnImpression.ID, bonus: 1, addendum: "If the target can smell your breath.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("470e246e-7d78-43e2-bf43-a0e64aeeb754"),
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
