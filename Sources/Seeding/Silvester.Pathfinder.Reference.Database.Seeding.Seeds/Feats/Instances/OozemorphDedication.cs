using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OozemorphDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("1067c2c3-4d52-4e6c-b172-2fef11b5c246");

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
            yield return new TextBlock { Id = Guid.Parse("7399bd7b-d168-4e56-85c8-14c3eaf7257e"), Type = TextBlockType.Text, Text = "You are plagued by sporadic anatomical rearrangements, which grant you insights into other creatures with unusual anatomies. You become trained in Occultism and Ooze Lore; if you were already trained, you become an expert instead. You gain a +2 circumstance bonus to Reflex saves to avoid being Engulfed by creatures, and to checks to (action: Escape) after being Engulfed." };
            yield return new TextBlock { Id = Guid.Parse("2ed2952d-902b-4dc1-ad6a-5ed76db64dfb"), Type = TextBlockType.Text, Text = "As you develop more abilities based on your amorphous affliction, you become increasingly off-putting to mundane creatures. You take a penalty to Diplomacy checks against animals and humanoids. This penalty is equal to your number of class feats from the oozemorph archetype, to a maximum of –4 for four or more feats." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa2cbd49-4cff-48bc-a750-fe9eebf67045"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
