using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KnightReclaimantDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("e73df465-285e-4603-88e1-c15ab8700200");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Knight Reclaimant Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Knight Reclaimant archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ce0c32bf-52b6-4aef-ae0e-b7799ad18c2f"), Type = TextBlockType.Text, Text = $"You have sworn the Crimson Oath and become a full member of the Crimson Reclaimers. You gain expert proficiency in Stealth and Survival. Whenever you roll a success on a saving throw against an undead's special ability, you get a critical success instead. This applies to any abilities that come from being undead, including an undead's innate spells (but not its prepared or spontaneous spells)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("65537029-51d9-4bc3-871a-3840202c2238"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("7d233cba-54e9-4162-8f9d-ca600bb6c9ef"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
            builder.AddOr(Guid.Parse("7ed30f57-5623-4673-ba58-1eb48023d0bc"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("510b8bb9-982f-44fb-ab63-021528588137"), Alignments.Instances.TrueNeutral.ID);
                or.HaveSpecificAlignment(Guid.Parse("50a89105-3fa5-4ada-96ba-167445a425ec"), Alignments.Instances.LawfulNeutral.ID);
                or.HaveSpecificAlignment(Guid.Parse("ccd42d7a-3892-4ca8-88cb-73a965d5525c"), Alignments.Instances.NeutralGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("8d5181f9-a530-4746-b961-2689f409de3f"), Alignments.Instances.ChaoticGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("d9251f13-9cf5-45b0-9f1d-e7a96301e1c2"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("479fbbe1-afc4-45e0-9b48-80e47cf8257f"), Alignments.Instances.ChaoticNeutral.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0e763ea-4169-4bc2-a3cc-5b8d60205761"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
