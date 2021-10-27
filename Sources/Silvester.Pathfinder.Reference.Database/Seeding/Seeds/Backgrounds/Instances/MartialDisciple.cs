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
            builder.AddOr(Guid.Parse(""), or => 
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Dexterity.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.AddOr(Guid.Parse(""), or => 
            {
                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.CatFall.ID);
                });

                or.AddAnd(Guid.Parse(""), and => 
                {
                    and.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.QuickJump.ID);
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
