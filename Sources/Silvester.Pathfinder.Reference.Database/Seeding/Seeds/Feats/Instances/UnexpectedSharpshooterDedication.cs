using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnexpectedSharpshooterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("b1965615-3169-4bc0-8f45-7159dfe78a6f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unexpected Sharpshooter Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the unexpected sharpshooter archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e50d8e75-05d6-41c2-8de5-e93110a99eb5"), Type = TextBlockType.Text, Text = "Who needs skill when you’ve got dumb luck? Sometimes your shots hit miraculously, regardless of the fact that you seemed to slip when you pulled the trigger or that you weren’t aiming at your foe when you fired. You gain the (feat: Accidental Shot) activity." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ed8d191-8dac-47dc-9c97-73509ddc8db1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
