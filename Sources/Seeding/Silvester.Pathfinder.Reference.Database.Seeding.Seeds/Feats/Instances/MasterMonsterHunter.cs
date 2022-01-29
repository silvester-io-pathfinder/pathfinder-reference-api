using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterMonsterHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("5dea4fd0-2fb3-4a89-85df-ca2f027a6f70");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Monster Hunter",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0749e426-2456-455c-b1da-4a61aaf76884"), Type = TextBlockType.Text, Text = $"You have a nearly encyclopedic knowledge of all creatures of the world. You can use Nature to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} to identify any creature. In addition, you gain the benefits of {ToMarkdownLink<Models.Entities.Feat>("Monster Hunter", Feats.Instances.MonsterHunter.ID)} (and {ToMarkdownLink<Models.Entities.Feat>("Monster Warden", Feats.Instances.MonsterWarden.ID)}, if you have it) on a success as well as a critical success." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("2935317d-b427-4e69-8b90-4381da09a21b"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
            builder.HaveSpecificFeat(Guid.Parse("29494f6d-749c-4fd6-90b1-b140017bea6b"), Feats.Instances.MonsterHunter.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("640ad841-d1f1-49a8-a195-9e6e14cfc692"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
