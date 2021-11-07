using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationRuneCapacity : Template
    {
        public static readonly Guid ID = Guid.Parse("43a5a191-9d50-4325-9630-c791ea70a6c7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Rune Capacity",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("45e93505-85f9-4d09-bbf6-9c410577e5a8"), Type = TextBlockType.Text, Text = "Whether you’ve done some dabbling in orichalcum alloys or found another engineering solution, you’ve built your innovation in such a way that it can hold an additional property rune. Your innovation can have one more property rune than a normal item of its kind (to a maximum of four property runes with a +3 potency armor)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd63690f-acfb-4c66-85d7-53db211cee18"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
