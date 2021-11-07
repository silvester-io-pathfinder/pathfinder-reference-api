using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EAPrimalSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("f38ac28d-a90f-43b0-b96a-fd689605409f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "EA - Primal Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("60237483-728d-4251-ac49-a5f66f77948b"), Type = TextBlockType.Text, Text = "You’re trained in primal spell attack rolls and spell DCs. Your key spellcasting ability is Charisma. Add a primal cantrip that requires a spell attack roll to your spell repertoire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3057a672-2bf6-4eba-9bd9-a242a7e16f99"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
