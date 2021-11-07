using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GarudaMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("f5cdde65-4f84-494a-81ed-166eb214282f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Garuda Magic",
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
            yield return new TextBlock { Id = Guid.Parse("4934221d-3f3a-4c8f-8a9f-b866d48d10f9"), Type = TextBlockType.Text, Text = "You are descended from the wondrous garudas, and their keen senses manifest in your magical prowess. You can cast (spell: blur) and (spell: see invisibility) each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a42a1977-c53d-4c91-8d64-0ba823fe1643"), Feats.Instances.Plumekith.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("429114c1-158f-4c7f-8169-64054bf872fa"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
