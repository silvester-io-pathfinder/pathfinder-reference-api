using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class AncestralParagonFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("1d6f005c-1b19-4072-8609-62af32b427e2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ancestral Paragon",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("db6f1680-f693-4b5c-9dae-16516d0bd65a"), Type = Utilities.Text.TextBlockType.Text, Text = "Whether through instinct, study, or magic, you feel a deeper connection to your ancestry.You gain a 1st - level ancestry feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override IEnumerable<Effect> GetCharacterEffects()
        {
            yield return new GainAnyAncestryFeatEffect { Id = Guid.Parse("49d0032a-5c63-4167-9ce8-313fc52a4868"), Level = 1 };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71338c7c-743a-4a30-a6ec-ac044f733231"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 258
            };
        }
    }
}
