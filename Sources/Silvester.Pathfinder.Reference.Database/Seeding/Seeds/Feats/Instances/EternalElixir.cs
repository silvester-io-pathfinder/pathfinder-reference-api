using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EternalElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("7bd16098-d9e8-4780-834f-237f89244501");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eternal Elixir",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d1608327-b97f-4db8-bc94-86eb57d1c144"), Type = TextBlockType.Text, Text = "Your body readily accepts and retains minor changes. When you drink one of your alchemical items that has the (trait: elixir) and (trait: infused) traits and a duration of 1 minute or more, you can make the elixir’s duration indefinite. You can do so only if the elixir’s level is half your level or lower. If you later consume a different elixir and make it indefinite, the effect of the previous indefinite elixir ends." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e0317f0c-ed3f-468a-b792-40fa1f996f6b"), Feats.Instances.ExtendElixir.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6bc9573-1e8a-4e89-94e8-997802a48233"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
