using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TetraelementalAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("cb7cf658-ad95-4307-8933-d0cfd466c7ef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tetraelemental Assault",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ea298fbc-4f7d-498c-a64b-61baccb3597b"), Type = TextBlockType.Text, Text = $"Your {ToMarkdownLink<Models.Entities.Feat>("Elemental Assault", Feats.Instances.ElementalAssault.ID)} cycles through all four elements. When you use {ToMarkdownLink<Models.Entities.Feat>("Elemental Assault", Feats.Instances.ElementalAssault.ID)}, instead of choosing a single element, you can choose an element from the list when using the action, and then choose a different element at the beginning of each of your next 3 turns without spending an action; once you have chosen an element, you can't choose it again during this {ToMarkdownLink<Models.Entities.Feat>("Elemental Assault", Feats.Instances.ElementalAssault.ID)}, meaning you must select all four elements over the course of 4 turns." };
            yield return new TextBlock { Id = Guid.Parse("b6c0970b-d546-48a6-b250-fa44dc27e53d"), Type = TextBlockType.Text, Text = $"Each time you choose an element, until the beginning of your next turn, your {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} deal an additional 1d6 damage of the indicated type and have the trait corresponding to that element." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fcae040e-bb18-40b5-99a1-693cb3569af2"), Feats.Instances.ElementalAssault.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cbf010bd-cc18-46bc-a3be-3caa8e256214"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
