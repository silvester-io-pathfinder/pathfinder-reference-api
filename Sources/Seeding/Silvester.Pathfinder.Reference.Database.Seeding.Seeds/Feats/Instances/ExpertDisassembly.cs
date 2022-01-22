using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertDisassembly : Template
    {
        public static readonly Guid ID = Guid.Parse("92f1ba92-b58c-4e8e-be44-cc50a2e22e8d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Disassembly",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b560bddf-f152-4199-aba7-94e6c7597171"), Type = TextBlockType.Text, Text = $"You can apply the same techniques you use to reverse engineer objects to disable them. You can use Crafting instead of Thievery to {ToMarkdownLink<Models.Entities.SkillAction>("Disable a Device", SkillActions.Instances.DisableADevice.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Pick a Lock", SkillActions.Instances.PickALock.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9c1e8da9-1d31-4d6e-9472-b739f9f48d2c"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("3592803b-8c76-4f00-b20c-be271a4c7377"), Feats.Instances.ScroungerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3757df23-3f40-46fa-a81e-48674f3f88a1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
