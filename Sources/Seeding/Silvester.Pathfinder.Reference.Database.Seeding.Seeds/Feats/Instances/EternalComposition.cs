using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EternalComposition : Template
    {
        public static readonly Guid ID = Guid.Parse("c9bcdfa4-907f-40cd-aec0-11ce0c5f72fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eternal Composition",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cd059bfa-251a-4e03-b9ec-394c6ca687df"), Type = TextBlockType.Text, Text = $"The world is a stage upon which you are always playing. You are permanently quickened; you can use your extra action only to cast a composition cantrip that requires 1 action to cast." };
            yield return new TextBlock { Id = Guid.Parse("18223b42-c527-44be-be4f-956975d0701d"), Type = TextBlockType.Text, Text = $"While in exploration mode, you can declare that you are performing an eligible composition cantrip while using any exploration tactic. Even before your first turn in a combat encounter, that cantrip is active as if you had cast it on your previous turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("a1335669-6bff-4bb0-8251-6b4e7a75ce3f"), Muses.Instances.Maestro.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e3c3648-a21d-4e60-a75d-646a88a16d2b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
