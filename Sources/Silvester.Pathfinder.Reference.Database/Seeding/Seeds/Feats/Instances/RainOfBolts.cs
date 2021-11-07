using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RainOfBolts : Template
    {
        public static readonly Guid ID = Guid.Parse("9e2cf65d-15e0-49a2-bd77-a652017e529d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rain of Bolts",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e827f09d-628f-4fd7-8df5-1ea6d75d49a4"), Type = TextBlockType.Text, Text = "Throughout the day, your body produces powerful projectiles within your chassis. You fire them all at once in either a 30-foot cone or a 10-foot emanation. Foes in the area take 6d6 piercing damage. This increases to 7d6 at 12th level, 8d6 at 15th level, and 9d6 at 18th level." };
            yield return new TextBlock { Id = Guid.Parse("ba2797dc-bcaa-4e19-a9c7-31afa7c7d8c2"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("c7186a69-7630-4c75-88d1-26961d40b38a"), Type = TextBlockType.Text, Text = "~ Enhancement: The projectiles regenerate quicker, they are much more powerful, and you can refine the metallic content to harm certain creatures. You can use Rain of Bolts once per hour instead of once per day. The damage increases to 12d6 and each time you use the action, you can choose adamantine, cold iron, or silver. The damage from Rain of Bolts is treated as the metal you chose. At 20th level, the damage increases to 13d6." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("a60d6efa-4dde-4168-8eba-8c138a336d62"), Heritages.Instances.SharpshooterAutomaton.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0231b248-3cfc-42e0-b8ac-852904f21da1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
