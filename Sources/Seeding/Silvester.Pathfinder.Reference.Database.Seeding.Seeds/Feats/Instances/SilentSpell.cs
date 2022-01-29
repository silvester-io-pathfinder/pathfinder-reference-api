using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SilentSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("2ff82c32-8389-4988-8183-80a133bb6321");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Silent Spell",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5b57060-697a-4523-8624-cb9703af31d4"), Type = TextBlockType.Text, Text = $"You've learned how to cast many of your spells without speaking the words of power you would normally need to provide. If the next action you use is {ToMarkdownLink<Models.Entities.Rule>("Casting a Spell", Rules.Instances.CastASpell.ID)} that has a verbal component and at least one other component, you can remove the verbal component. This makes the spell quieter and allows you to cast it in areas where sound can't carry. However, the spell still has visual manifestations, so this doesn't make the spell any less obvious to someone who sees you casting it. When you use Silent Spell, you can choose to gain the benefits of {ToMarkdownLink<Models.Entities.Feat>("Conceal Spell", Feats.Instances.ConcealSpell.ID)}, and you don't need to attempt a Deception check because the spell has no verbal components." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("55af3472-cb49-44ac-a7cf-3c4c4b91cf5d"), Feats.Instances.ConcealSpell.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b4c1c5a-06ef-430e-b129-2dccfe99c893"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
