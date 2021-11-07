using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HellknightSigniferDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("c03890fd-20d0-42f5-be5b-f0c4d9961db7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hellknight Signifer Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Hellknight signifer or Hellknight armiger archetypes.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("22f22233-afee-4d78-860c-d8689a552f67"), Type = TextBlockType.Text, Text = "You have bolstered your force of will with the power of the Measure and the Chain. Upon initiation, you receive a signifer mask, often devoid of eyeholes or other decorative features. The mask doesn’t obscure your vision, though it makes it impossible for others to see your eyes. While wearing your signifer’s mask, you gain +1 circumstance bonus to Deception checks to (action: Lie), Intimidation checks, and Deception DCs against (action: Sense Motive). You gain expert proficiency in Intimidation (or in another skill in which you’re trained of your choice, if you were already an expert in Intimidation) as well as in your choice of Arcana, Nature, Occultism, or Religion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyMagicTradition(Guid.Parse("ea8f40cb-5d0f-4155-ab81-199e779c494f"));
            builder.HaveSpecificFeat(Guid.Parse("0865b27e-b6c6-40b1-9138-48945bae18a2"), Feats.Instances.HellknightArmigerDedication.ID);
            builder.AddOr(Guid.Parse("4abb5b62-ea4f-4103-8197-333bd232282b"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("f4511fc3-1842-438e-9bd3-04d65af9cff6"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("50259f4c-34ec-4d5d-a4bd-215dd7a2c4c5"), Alignments.Instances.LawfulEvil.ID);
            });
            builder.Manual(Guid.Parse("30a59f13-ed42-46c2-a2a0-8f65e2177225"), "Member of a Hellknight order.");
            builder.Manual(Guid.Parse("5de85a54-4914-497f-bc66-7aa37ff35d78"), "Passed the Hellknight Test.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ec98b86-e5cf-4595-bd44-d2b6b7d88369"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
