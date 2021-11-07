using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VerdantMetamorphosis : Template
    {
        public static readonly Guid ID = Guid.Parse("19cc09e8-1574-479f-8776-b9b42a971f91");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Verdant Metamorphosis",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d2425b1-4149-4e41-816b-251bf4c08a55"), Type = TextBlockType.Text, Text = "You transform into a plant version of yourself. You gain the plant trait and lose any trait that’s inappropriate for your new form (typically humanoid for a PC, but also possibly animal or fungus). You can change from a form that looks mostly like your old self into a tree or any other non-creature plant as a single action, which has the concentrate trait. This has the same effect as (Spell: tree shape), except you can turn into any kind of non-creature plant and your AC is 30." };
            yield return new TextBlock { Id = Guid.Parse("e46b9fb6-06cf-4d21-8202-9af72e93f932"), Type = TextBlockType.Text, Text = "If you rest for 10 minutes while transformed into a noncreature plant during daylight hours under direct sunlight, you recover half your maximum Hit Points. If you take your daily rest in this way, the rest restores you to maximum Hit Points and removes all non-permanent drained, enfeebled, clumsy, and stupefied conditions, as well as all poisons and diseases of 19th level or lower." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("8b828686-4655-4ca1-9518-b58157f7ce01"), DruidicOrders.Instances.Leaf.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73674d3c-8d50-4151-929e-858098ba4905"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
