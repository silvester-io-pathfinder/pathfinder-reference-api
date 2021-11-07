using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArmorAssist : Template
    {
        public static readonly Guid ID = Guid.Parse("466da8ec-5f11-4616-bf9c-e32ffa177dc2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Armor Assist",
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
            yield return new TextBlock { Id = Guid.Parse("be02ac61-558d-48fd-808d-1d113c6d2d34"), Type = TextBlockType.Text, Text = "After your service aiding armored combatants, you are practiced in helping yourself and others don heavy gear. You can attempt an Athletics or Warfare Lore check with a DC determined by the GM (but usually 15 for common armor, DC 20 for uncommon armor, and DC 25 for rare armor) to halve the time you take to don armor. You can halve an ally’s time to don armor by working with them to don the armor and succeeding at an Athletics or Warfare Lore check against the same DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("00c7ef0f-114c-4d83-8d20-d0025c45dc23"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("4b57c2b4-89fa-4426-b9d9-01c1ffcff114"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
                or.HaveSpecificLoreSpecificProficiency(Guid.Parse("eaad8589-006f-493c-9f5a-dc409bae4aa4"), Proficiencies.Instances.Trained.ID, Lores.Instances.Warfare.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("569ae69a-6efb-4c44-9ed6-9b246ac04f20"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
