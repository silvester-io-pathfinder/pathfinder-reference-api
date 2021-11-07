using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OozemorphDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("e15b93cf-29e1-4fd2-ad3d-9f40aa691369");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Oozemorph Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the oozemorph archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f1d051a0-e78f-454c-a32a-8721a18c2a55"), Type = TextBlockType.Text, Text = "You are plagued by sporadic anatomical rearrangements, which grant you insights into other creatures with unusual anatomies. You become trained in Occultism and Ooze Lore; if you were already trained, you become an expert instead. You gain a +2 circumstance bonus to Reflex saves to avoid being Engulfed by creatures, and to checks to (action: Escape) after being Engulfed." };
            yield return new TextBlock { Id = Guid.Parse("4230dfc1-42fb-47c5-a90a-9b2dd282dffc"), Type = TextBlockType.Text, Text = "As you develop more abilities based on your amorphous affliction, you become increasingly off-putting to mundane creatures. You take a penalty to Diplomacy checks against animals and humanoids. This penalty is equal to your number of class feats from the oozemorph archetype, to a maximum of –4 for four or more feats." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42fbfc66-fdb3-47a5-a893-1382c367baba"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
