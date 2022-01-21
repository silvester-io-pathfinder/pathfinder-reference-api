using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlamboyantAthlete : Template
    {
        public static readonly Guid ID = Guid.Parse("9e82ced5-2298-4edc-a965-94c593786262");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flamboyant Athlete",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ec63af04-42df-426e-947f-adf6fc2a166e"), Type = TextBlockType.Text, Text = "Your panache allows you to perform incredible feats: climbing, swimming, and leaping far beyond your normal capacity. While you have panache, you gain the following benefits." };
            yield return new TextBlock { Id = Guid.Parse("56363127-4a4a-469c-8d8f-7189622b72a4"), Type = TextBlockType.Enumeration, Text = " : You gain climb and swim Speeds equal to half your land Speed." };
            yield return new TextBlock { Id = Guid.Parse("2cf58798-bc5e-4ee3-889c-c16473b8a810"), Type = TextBlockType.Enumeration, Text = " : The DCs of your (action: High Jumps | High Jump) and (action: Long Jumps | Long Jump) decrease by 10. This doesn't combine with other abilities that reduce those DCs." };
            yield return new TextBlock { Id = Guid.Parse("4b9c5048-2ec6-40ef-9cba-c3945a5f0d38"), Type = TextBlockType.Enumeration, Text = " : The distance you can move with a vertical (action: Leap) increases to 5 feet. Your distance for a horizontal (action: Leap) increases to 15 feet if your Speed is at least 15 feet, or to 20 feet if your Speed is at least 30 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("32ce23c1-4a1b-4b03-a2a5-626ae067a7dc"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("24e2f51d-0adc-41af-b1d1-430c7930362d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
