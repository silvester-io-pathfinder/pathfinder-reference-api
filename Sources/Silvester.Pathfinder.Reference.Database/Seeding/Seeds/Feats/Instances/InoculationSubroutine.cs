using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InoculationSubroutine : Template
    {
        public static readonly Guid ID = Guid.Parse("4d62b881-0c09-40ca-b8bc-6566e605beeb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inoculation Subroutine",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a0199c64-ae69-44b7-bb27-0df37884d6a0"), Type = TextBlockType.Text, Text = "Your nanites reject diseases with ease. Each time you succeed at a Fortitude save against an ongoing disease, you reduce its stage by 2, or by 1 against a (trait: virulent) disease. Each critical success you achieve against an ongoing disease reduces its stage by 3, or by 2 against a (trait: virulent) disease." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e108f96-492a-4e0c-b24b-9b4d3756e804"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
