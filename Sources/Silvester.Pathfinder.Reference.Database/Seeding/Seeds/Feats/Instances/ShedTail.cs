using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShedTail : Template
    {
        public static readonly Guid ID = Guid.Parse("aa424f5a-a78b-4ee1-a157-887c7a1d881b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shed Tail",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You become grabbed.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b30cf8f6-b1a0-434a-8fad-ad579d4415a7"), Type = TextBlockType.Text, Text = "You can shed your tail to escape. You cease being grabbed, then (Action: Stride) without triggering any reactions from the creature that grabbed you. It takes 1 week for your tail to fully grow back. Until it does, you can’t use your tail unarmed attack, and you take a -2 circumstance penalty on checks to (Action: Balance)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6144a02e-5b2f-4ab6-92c0-6df15a5b97fd"), Feats.Instances.TailWhip.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("98ebcfbd-0f13-43c3-8a50-f38252c17f0f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
