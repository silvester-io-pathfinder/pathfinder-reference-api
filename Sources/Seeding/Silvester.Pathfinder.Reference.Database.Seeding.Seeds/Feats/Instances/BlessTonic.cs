using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlessTonic : Template
    {
        public static readonly Guid ID = Guid.Parse("a54891dd-82d6-41f8-adf5-859874fff37c");

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
            yield return new TextBlock { Id = Guid.Parse("e2e3e65f-865f-45de-88e8-2c89b35cbeb9"), Type = TextBlockType.Text, Text = $"You channel positive energy into restoratives that ward against harm. When you {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} an alchemical item that restores Hit Points (rather than create it with advanced alchemy, {ToMarkdownLink<Models.Entities.Feat>("Quick Alchemy", Feats.Instances.QuickAlchemy.ID)}, or another means), it becomes a blessed alchemical item and gains the {ToMarkdownLink<Models.Entities.Trait>("positive", Traits.Instances.Positive.ID)} trait. For example, an elixir of life would become a blessed elixir of life. When a creature regains Hit Points using a blessed alchemical item, the overflowing energy grants them negative resistance 5 for 1 round, or negative resistance 10 if you are legendary in Crafting." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1a050731-0847-48b5-9d9b-9920c38a965c"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
            builder.HaveAnyDeitySpecificFont(Guid.Parse("2a39f421-0276-4856-b3a7-adda2eeede58"), DivineFonts.Instances.Heal.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("51604f6d-4f6c-4a0e-a4a5-47bde38aad27"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
