using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Battleforger : Template
    {
        public static readonly Guid ID = Guid.Parse("ffbf2ef6-3ae8-41b0-bc9e-2d07053c4579");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Battleforger",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ca0791a6-ef80-4a5f-944e-5f1005c9c1eb"), Type = TextBlockType.Text, Text = "You can sharpen weapons, polish armor, and apply special techniques to temporarily gain better effects from your armaments. By spending 1 hour working on a weapon or armor, you can grant it the effects of a +1 potency rune until your next daily preparations, gaining a +1 item bonus to attack rolls for a weapon or increasing armor’s item bonus to AC by 1. This has no effect if the weapon or armor already had a potency rune." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("773aacf6-1f60-40a2-b7ee-a990bd79b9be"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8de3dd9e-840d-4191-9912-18daf1edce67"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
