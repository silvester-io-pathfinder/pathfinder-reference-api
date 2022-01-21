using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TricksterTengu : Template
    {
        public static readonly Guid ID = Guid.Parse("dba737c4-9f20-4c0d-96c5-3981ca74e62e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Trickster Tengu",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1790ab19-3af4-4935-9e9b-fec9a53cc0b8"), Type = TextBlockType.Text, Text = "You can transform yourself or the bodies of others to express your displeasure. Once per day, you can cast either (spell: aerial form) or (spell: baleful polymorph) as a 7th-level primal innate spell. You must take the form of a bird when using this (spell: aerial form)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bcf46d99-a21f-46e7-9e76-adf5df39a6a4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
