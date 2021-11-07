using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImproviseTool : Template
    {
        public static readonly Guid ID = Guid.Parse("940659c6-aa9f-4fad-bc49-79aec748debf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improvise Tool",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ed249c2-93e7-4273-8d4b-22d9129b7a72"), Type = TextBlockType.Text, Text = "You can jury-rig solutions when you don’t have the proper tools on hand. You can attempt to (action: Repair) damaged items without a (item: repair kit)." };
            yield return new TextBlock { Id = Guid.Parse("5947021f-9be1-46fc-8355-25d166102ced"), Type = TextBlockType.Text, Text = "If you have the raw materials available, you can (action: Craft) a basic (item: caltrop set | Caltrops), (item: candle), (item: compass), (item: crowbar), (item: fishing tackle), (item: flint and steel), (item: hammer), (item: ladder | Ladder 10-foot), (item: piton), (item: rope | Rope 50 feet), (item: 10-foot pole | Ten-Foot Pole), (item: replacement thieves’ picks | Replacement Picks), (item: long | Tool long) or (item: short tool | Tool short), or (item: torch) without consulting a (item: basic crafter’s book)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ba059dac-7ab4-401f-beb5-09ea2c867214"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bfa1197f-c73d-46c9-a508-02e8cae8991b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
