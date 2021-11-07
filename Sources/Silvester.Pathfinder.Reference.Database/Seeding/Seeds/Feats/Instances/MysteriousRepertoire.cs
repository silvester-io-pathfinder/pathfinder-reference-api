using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MysteriousRepertoire : Template
    {
        public static readonly Guid ID = Guid.Parse("515c5526-48f6-4194-baca-1c7e311c181f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mysterious Repertoire",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3cbdd58c-7bdd-4968-b97f-b333ce22f43c"), Type = TextBlockType.Text, Text = "Your mystery holds unknowable depths of magic not always associated with the divine. You can have one spell in your spell repertoire not on the divine spell list, in addition to spells you’ve added to your spell list from feats like (feat: Divine Access). You cast that spell as a divine spell. You can swap which spell you add and from which tradition as you could any other oracle spell, but you can’t use this feat to have more than one spell from another tradition in your spell repertoire at the same time." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("70fc2fb1-443e-471b-94e4-dc29e23cce06"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
