using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImproviseTool : Template
    {
        public static readonly Guid ID = Guid.Parse("8496e5ab-587e-4723-9bbb-4787cbbe13f6");

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
            yield return new TextBlock { Id = Guid.Parse("457fcec1-77ab-4204-b6fa-cb1ca18b970a"), Type = TextBlockType.Text, Text = "You can jury-rig solutions when you don’t have the proper tools on hand. You can attempt to (action: Repair) damaged items without a (item: repair kit)." };
            yield return new TextBlock { Id = Guid.Parse("2a667415-812c-4288-8e81-5fa9906fb11f"), Type = TextBlockType.Text, Text = "If you have the raw materials available, you can (action: Craft) a basic (item: caltrop set | Caltrops), (item: candle), (item: compass), (item: crowbar), (item: fishing tackle), (item: flint and steel), (item: hammer), (item: ladder | Ladder 10-foot), (item: piton), (item: rope | Rope 50 feet), (item: 10-foot pole | Ten-Foot Pole), (item: replacement thieves’ picks | Replacement Picks), (item: long | Tool long) or (item: short tool | Tool short), or (item: torch) without consulting a (item: basic crafter’s book)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("79a985ca-536c-4952-943b-52519b9cb08f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe3b685f-98e2-4b28-839b-64d5ef3f6949"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
