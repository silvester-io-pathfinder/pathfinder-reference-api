using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExplosiveSavant : Template
    {
        public static readonly Guid ID = Guid.Parse("83f7f92d-fe6e-405a-96f0-96ee0fa96be1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Explosive Savant",
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
            yield return new TextBlock { Id = Guid.Parse("31708932-edb8-4e2e-b18d-cbb397950a45"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("032129be-8735-4acf-a15d-ce132456d36b"), Type = TextBlockType.Text, Text = "A lifetime wielding firearms and explosive ordinance amid the chaos of battle has granted you great skill with volatile weapons. You become trained in simple and martial bombs and firearms." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73dfe785-9256-4e09-a390-05a21bd85bac"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
