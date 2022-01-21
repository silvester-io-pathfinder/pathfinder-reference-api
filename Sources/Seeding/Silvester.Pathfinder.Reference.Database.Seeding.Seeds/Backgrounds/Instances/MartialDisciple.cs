using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class MartialDisciple : Template
    {
        public static readonly Guid ID = Guid.Parse("19ee9a31-1b65-4dc3-b7cf-5e11827401e2");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Martial Disciple",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("cce853eb-b6d3-4130-bb12-030230c77f4b"), Type = TextBlockType.Text, Text = "You dedicated yourself to intense training and rigorous study to become a great warrior. The school you attended might have been a traditionalist monastery, an elite military academy, or the local branch of a prestigious mercenary organization." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("1634b90b-0096-4748-87f5-e212ebae94f1"), or => 
            {
                or.GainSpecificAbilityBoost(Guid.Parse("52c07c3c-50c7-478c-8695-df473afd1441"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("87e8f7eb-d6c6-44cf-907b-c08f9e683662"), Stats.Instances.Dexterity.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("a6643196-5402-44fb-9d1d-321fdd0e5913"));
            builder.AddOr(Guid.Parse("357924d7-8c7d-4f47-a8b1-c5591544777d"), or => 
            {
                or.AddAnd(Guid.Parse("b719564e-9eb5-4fc0-aa1d-8ab87f40d46e"), and =>
                {
                    and.GainSpecificSkillProficiency(Guid.Parse("cc1d266d-0873-4733-b615-dab492fca244"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
                    and.GainSpecificFeat(Guid.Parse("272c7c10-0a1b-49ae-8591-d947d1e764b1"), Feats.Instances.CatFall.ID);
                });

                or.AddAnd(Guid.Parse("54dde33f-2d96-4e47-8b50-303da7cf4e25"), and => 
                {
                    and.GainSpecificSkillProficiency(Guid.Parse("7751d5bd-af97-4a48-b09b-c16aa41905e4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
                    and.GainSpecificFeat(Guid.Parse("265c1fba-248e-4fd2-8b19-cd3882bdc22a"), Feats.Instances.QuickJump.ID);
                });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d2cb128-d0cf-4c92-a5fb-90ca9c98a73e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 63
            };
        }
    }
}
