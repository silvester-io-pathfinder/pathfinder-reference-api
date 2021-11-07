using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EternalComposition : Template
    {
        public static readonly Guid ID = Guid.Parse("347e2f80-503f-4bf3-b619-b5dac45f5c56");

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
            yield return new TextBlock { Id = Guid.Parse("5723b056-dc86-4849-9392-b002864f5c06"), Type = TextBlockType.Text, Text = "The world is a stage upon which you are always playing. You are permanently quickened; you can use your extra action only to cast a composition cantrip that requires 1 action to cast." };
            yield return new TextBlock { Id = Guid.Parse("7297a127-dc11-4fa7-b091-198326576348"), Type = TextBlockType.Text, Text = "While in exploration mode, you can declare that you are performing an eligible composition cantrip while using any exploration tactic. Even before your first turn in a combat encounter, that cantrip is active as if you had cast it on your previous turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("05c2f34d-aa97-47c8-acab-9ddeb63c07d9"), Muses.Instances.Maestro.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e580c26-b006-47f6-8ae0-5be337e98cc2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
