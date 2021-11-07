using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TricksterTengu : Template
    {
        public static readonly Guid ID = Guid.Parse("7ac60061-c602-4a2f-ba05-e786809a231d");

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
            yield return new TextBlock { Id = Guid.Parse("3e0276c2-5998-482d-8426-53689f4b03e8"), Type = TextBlockType.Text, Text = "You can transform yourself or the bodies of others to express your displeasure. Once per day, you can cast either (spell: aerial form) or (spell: baleful polymorph) as a 7th-level primal innate spell. You must take the form of a bird when using this (spell: aerial form)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22d4d9dd-00c4-48ef-8a0e-9a610ae6d8f4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
