using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FerociousShape : Template
    {
        public static readonly Guid ID = Guid.Parse("e94d92e6-5914-4f09-872e-96dc256e2f2d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ferocious Shape",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9108644f-070b-41c1-8e2b-0d564881652c"), Type = TextBlockType.Text, Text = "You have mastered the shape of ferocious dinosaurs. Add the forms listed in (Spell: dinosaur form) to your (Spell: wild shape) list. Whenever you use (Spell: wild shape) to take a form that grants you a specific Athletics modifier, you gain a +1 status bonus to your Athletics checks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0d8251a9-c26c-4407-8a35-a6f57e134ff0"), Feats.Instances.WildShape.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("80818c1d-e0ac-4943-8471-6a3a4cb33ff1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
