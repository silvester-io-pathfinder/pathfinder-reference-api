using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PsychicBeacon : Template
    {
        public static readonly Guid ID = Guid.Parse("ccdb0d80-558b-4e8d-9e4c-068bb0fa544f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Psychic Beacon",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0dc7f479-ae73-4835-8fa0-525efa4a0158"), Type = TextBlockType.Text, Text = "As your spell strikes a target, you plant a beacon in their mind that announces their presence to those nearby. Use this amp in place of the psi cantrip’s normal amp entry. The amped spell must be one that has one or more targets and must either require a spell attack roll or have a saving throw." };
            yield return new TextBlock { Id = Guid.Parse("5d4af76b-0c08-41ec-b895-b3f71c60e74c"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("34986ecb-c1fb-4e99-b705-f85d81727ea2"), Type = TextBlockType.Text, Text = "~ Amp: Choose one creature that’s hit by the spell (if the spell has a spell attack roll) or that fails its save against the spell (if the spell requires a save). A magical beacon leaves telltale clues that make it easier to notice the creature for 1 minute. If the target was invisible, it’s instead merely concealed for 1 minute. If it was concealed, it’s no longer concealed for 1 minute, as the beacon clears up the concealment and makes it perfectly easy to see, even in areas of poor visibility." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc629437-4b02-4db1-b693-73f5772dc161"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
