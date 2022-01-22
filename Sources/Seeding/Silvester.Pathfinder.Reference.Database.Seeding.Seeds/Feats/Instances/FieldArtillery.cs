using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FieldArtillery : Template
    {
        public static readonly Guid ID = Guid.Parse("41cc7f10-1364-4ddd-99a6-dc5a11817036");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Field Artillery",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5ba03067-b80f-4230-a396-cb786f7f9d04"), Type = TextBlockType.Text, Text = $"While castles are generally obliging enough to stay in one place, out in the field positioning is of paramount importance—a gun in the wrong place is worse than useless. You can {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} with an adjacent mounted siege weapon to increase its Speed by 10 feet for one round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c25fc912-6f88-481e-a2ac-78ff6c13e6b2"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b67148cb-aa64-4144-b639-42e184c8db5d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
