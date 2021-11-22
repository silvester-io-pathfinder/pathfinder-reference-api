using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HellknightSigniferDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("1e7e4069-14f9-489f-93d6-4f380119de30");

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
            yield return new TextBlock { Id = Guid.Parse("071a5183-92f0-40c0-b7ef-69e3ad0b354b"), Type = TextBlockType.Text, Text = "You have bolstered your force of will with the power of the Measure and the Chain. Upon initiation, you receive a signifer mask, often devoid of eyeholes or other decorative features. The mask doesn't obscure your vision, though it makes it impossible for others to see your eyes. While wearing your signifer's mask, you gain +1 circumstance bonus to Deception checks to (action: Lie), Intimidation checks, and Deception DCs against (action: Sense Motive). You gain expert proficiency in Intimidation (or in another skill in which you're trained of your choice, if you were already an expert in Intimidation) as well as in your choice of Arcana, Nature, Occultism, or Religion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyMagicTradition(Guid.Parse("ebdc5023-c32f-4d29-a9ea-34c25bd1df2e"));
            builder.HaveSpecificFeat(Guid.Parse("11295224-3dae-4c2a-8ecd-ff1a47ed8c5c"), Feats.Instances.HellknightArmigerDedication.ID);
            builder.AddOr(Guid.Parse("3ba53d27-1d1e-4094-aefb-001847b01613"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("ef0c7831-8593-4ce4-a8b5-08efd6961022"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("912f1551-3d00-479b-93b4-ce8a5ba394a3"), Alignments.Instances.LawfulEvil.ID);
            });
            builder.Manual(Guid.Parse("c2bf3f4d-3599-4306-92a8-f234c4b308e6"), "Member of a Hellknight order.");
            builder.Manual(Guid.Parse("1126a4ba-fabd-416e-b06e-841bc7b2cd76"), "Passed the Hellknight Test.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e590d20-a872-4f4e-afb0-511ad01cd479"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
