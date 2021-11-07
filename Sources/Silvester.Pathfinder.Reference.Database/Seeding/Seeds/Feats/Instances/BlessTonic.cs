using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlessTonic : Template
    {
        public static readonly Guid ID = Guid.Parse("96bf69ac-a65d-4a57-ae40-cdaf3595a035");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bless Tonic",
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
            yield return new TextBlock { Id = Guid.Parse("5fd45f55-37a9-4623-bc68-9b5d43886c70"), Type = TextBlockType.Text, Text = "You channel positive energy into restoratives that ward against harm. When you (action: Craft) an alchemical item that restores Hit Points (rather than create it with advanced alchemy, (feat:lvl--1: Quick Alchemy), or another means), it becomes a blessed alchemical item and gains the (trait: positive) trait. For example, an elixir of life would become a blessed elixir of life. When a creature regains Hit Points using a blessed alchemical item, the overflowing energy grants them negative resistance 5 for 1 round, or negative resistance 10 if you are legendary in Crafting." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0f9ffdb0-b100-432a-b2bd-dc23e855911c"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
            builder.HaveAnyDeitySpecificFont(Guid.Parse("188a459a-30e5-42ad-8c08-611b1e4105b9"), DivineFonts.Instances.Heal.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("caa7a078-5144-41eb-8b96-d867433fa262"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
