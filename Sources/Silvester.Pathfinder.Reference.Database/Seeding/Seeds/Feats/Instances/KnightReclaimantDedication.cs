using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KnightReclaimantDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("d1ea7e31-e15e-4b66-b1d2-de6aca4d32c9");

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
            yield return new TextBlock { Id = Guid.Parse("cff2f607-d5c1-4cf7-b8c1-1884c16d0cf5"), Type = TextBlockType.Text, Text = "You have sworn the Crimson Oath and become a full member of the Crimson Reclaimers. You gain expert proficiency in Stealth and Survival. Whenever you roll a success on a saving throw against an undead’s special ability, you get a critical success instead. This applies to any abilities that come from being undead, including an undead’s innate spells (but not its prepared or spontaneous spells)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("42594b87-73f8-4a43-beff-4ee4d3fb2718"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("8e7b04f2-bf6e-4f1a-bb5b-dbb9ac4eeace"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
            builder.AddOr(Guid.Parse("03aeb4c1-3708-4309-8fbb-ab67724cb787"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("ed1445a3-057f-46d5-9de8-fc5c20700ea8"), Alignments.Instances.TrueNeutral.ID);
                or.HaveSpecificAlignment(Guid.Parse("7cea4462-5d0a-4271-b426-97fb77c0e9ae"), Alignments.Instances.LawfulNeutral.ID);
                or.HaveSpecificAlignment(Guid.Parse("3fa2fcf5-27d2-4877-bd14-f9c2eb6440a0"), Alignments.Instances.NeutralGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("ff4d6216-34b6-45d8-8dcc-e8e251baa45a"), Alignments.Instances.ChaoticGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("a18cdaa0-489f-4b6c-94cc-61a8c15eedc4"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("f5589552-d3a4-4d97-a666-e83380dd84e3"), Alignments.Instances.ChaoticNeutral.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79a0b9c6-7616-42f5-8a5d-8026cdca40fe"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
