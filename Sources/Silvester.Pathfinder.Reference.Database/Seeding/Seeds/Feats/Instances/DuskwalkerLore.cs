using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DuskwalkerLore : Template
    {
        public static readonly Guid ID = Guid.Parse("ae631df4-a247-4d7e-9330-4de7972c74a1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Duskwalker Lore",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e4fe5e10-659d-48fb-9432-27b206990082"), Type = TextBlockType.Text, Text = "You either found another duskwalker who taught you the secrets of your kind, or you managed to research your unusual heritage. You gain the trained proficiency rank in Medicine and Religion. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in Boneyard Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6891425a-2576-4b14-988b-4e86c6feed89"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
