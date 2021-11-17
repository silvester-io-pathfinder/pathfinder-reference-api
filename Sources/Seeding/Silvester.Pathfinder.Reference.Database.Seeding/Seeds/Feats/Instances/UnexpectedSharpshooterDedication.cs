using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnexpectedSharpshooterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("2e9c0b49-75b0-4628-a7b8-3303702b6ace");

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
            yield return new TextBlock { Id = Guid.Parse("14f7f20e-c207-4e98-860c-f1c0d2e92d6c"), Type = TextBlockType.Text, Text = "Who needs skill when you’ve got dumb luck? Sometimes your shots hit miraculously, regardless of the fact that you seemed to slip when you pulled the trigger or that you weren’t aiming at your foe when you fired. You gain the (feat: Accidental Shot) activity." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b21fb1e7-a6c2-40a5-9953-aba9336b0e40"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
