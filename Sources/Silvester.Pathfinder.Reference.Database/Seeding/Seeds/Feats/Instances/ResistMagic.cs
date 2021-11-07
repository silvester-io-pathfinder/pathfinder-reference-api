using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ResistMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("5fc33bec-f29e-401d-9414-6c691929e8c9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resist Magic",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a saving throw against a harmful magical effect but haven't rolled yet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c7856ae-ae6e-4d16-94ce-74dc59cad4fd"), Type = TextBlockType.Text, Text = "Your innate magic protects you. You gain a +1 circumstance bonus to the triggering saving throw. Additionally, if the triggering effect is (trait: arcane), if you roll a success, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("891fcf6e-85fa-4584-a5bc-15987d92a910"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
