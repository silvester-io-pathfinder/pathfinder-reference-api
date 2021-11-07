using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RangedCombatant : Template
    {
        public static readonly Guid ID = Guid.Parse("22465734-5739-4365-8f7e-d3cd3702153d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ranged Combatant",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dd79d62d-fd0a-4a43-85a3-669f9b613b8f"), Type = TextBlockType.Text, Text = "Spines, flame jets, and holy blasts are just some of the ways your eidolon might strike from a distance. It gains a ranged unarmed attack with a range increment of 30 feet that deals 1d4 damage and has the (trait: magical) and (trait: propulsive) traits. When you select this feat, choose a damage type: acid, bludgeoning, cold, electricity, fire, negative, piercing, positive, or slashing. If your eidolon is a celestial, fiend, or monitor with an alignment other than true neutral, you can choose a damage type in its alignment." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3285535-d96a-45ef-ac73-492b3dfb3b6a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
