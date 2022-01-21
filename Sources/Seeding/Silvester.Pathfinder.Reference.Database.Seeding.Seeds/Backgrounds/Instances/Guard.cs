using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Guard : Template
    {
        public static readonly Guid ID = Guid.Parse("5ea02322-252b-4991-8cd9-ca0f14c4349d");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Guard",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("118502a0-15e4-4719-b27a-26532fcb0279"), Type = TextBlockType.Text, Text = "You served in the guard, out of either patriotism or the need for coin. Either way, you know how to get a difficult suspect to talk. However you left the guard, you might think of adventuring as a way to use your skills on a wider stage." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("32b09ef8-3212-4309-9f18-4671617ca285"), or => 
            {
                or.GainSpecificAbilityBoost(Guid.Parse("08c91a22-5fc1-49ce-bd9b-f29f2553242e"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("2e8f6bef-46bc-425c-a02a-48ab1b1dd2e8"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("71b9b64d-db30-47e1-98aa-21fdc87f155f"));
            builder.GainSpecificSkillProficiency(Guid.Parse("cf028c1a-9248-4a65-9f1c-82c4e7e90d80"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);

            builder.AddOr(Guid.Parse("d9aa0c9b-0663-441a-82cd-cc9d57866910"), or =>
            {
                or.GainSpecificLoreProficiency(Guid.Parse("18e959ba-041f-4b9a-923a-05361896bce6"), Proficiencies.Instances.Trained.ID, Lores.Instances.Legal.ID);
                or.GainSpecificLoreProficiency(Guid.Parse("cb3a0fb1-8871-42cb-839b-fe8e4cee5888"), Proficiencies.Instances.Trained.ID, Lores.Instances.Warfare.ID);
            });

            builder.GainSpecificFeat(Guid.Parse("74532372-cb45-4f5f-a3ce-2c5a44c88ed9"), Feats.Instances.QuickCoercion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d0d6ac9-91f5-464f-b74a-e27304fd7db9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
