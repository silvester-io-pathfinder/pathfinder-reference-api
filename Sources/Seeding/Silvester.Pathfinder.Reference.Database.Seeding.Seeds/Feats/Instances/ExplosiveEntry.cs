using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExplosiveEntry : Template
    {
        public static readonly Guid ID = Guid.Parse("7def9292-fd99-43bc-b9fd-782b971c9ab4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Explosive Entry",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ccc4d19b-517c-4f9c-9b28-54d4597610da"), Type = TextBlockType.Text, Text = "You know exactly how to make a memorable entrance... by detonating a bomb to produce a devastating explosion, of course! You (feat: Set Explosives) on a door, window, container, or heavy gate. When the explosives detonate, you can attempt an Engineering Lore check to (action: Force Open) the target. If a bomb would add an item bonus to attack rolls, add that item bonus to your Engineering Lore check. Since you're blasting your way in, you can't avoid breaking the object or structure. If you roll a critical success, you get a success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ec731053-6010-419b-8966-4a2dce40a04a"), Feats.Instances.DemolitionistDedication.ID);
            builder.HaveSpecificLoreSpecificProficiency(Guid.Parse("b052e648-87ad-4bde-a5bf-35255d9e548f"), Proficiencies.Instances.Master.ID, Lores.Instances.Engineering.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cfcc6ab1-e510-4212-9057-814fedd40ba7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
