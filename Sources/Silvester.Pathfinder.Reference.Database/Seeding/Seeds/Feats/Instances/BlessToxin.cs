using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlessToxin : Template
    {
        public static readonly Guid ID = Guid.Parse("630d4ee7-fd64-42bd-9b44-7f6b9512a147");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bless Toxin",
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
            yield return new TextBlock { Id = Guid.Parse("b4274805-b89a-4844-9926-9f50d2736bab"), Type = TextBlockType.Text, Text = "You pour negative energy into toxins you create to further debilitate your targets. When you (action: Craft) an alchemical poison (rather than create it with advanced alchemy, (feat:lvl--1: Quick Alchemy), or another means), it becomes a blessed alchemical poison and gains the (trait: negative) trait. When a creature is afflicted with a blessed alchemical poison, for 1 round, any Hit Points it would regain from a positive effect are reduced by 5, or by 10 if you are legendary in Crafting." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ee21faca-dc77-4e07-891b-af87ac11d48a"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
            builder.HaveAnyDeitySpecificFont(Guid.Parse("61d29da2-ccb4-4485-b178-9b0162287314"), DivineFonts.Instances.Harm.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4113f3e2-9382-4cfd-8f59-b9caaa828d4f"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
