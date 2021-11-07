using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellshotDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("7155cbab-89a1-4920-a353-78bd9a6d00c1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spellshot Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat other than Beast Gunner Dedication until you've gained two other feats from the spellshot or beast gunner archetypes.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2548d642-4712-4bae-a8de-c5db13086246"), Type = TextBlockType.Text, Text = "You’ve steeped yourself in magic and gunplay to the extent that you can conjure bullets from thin air, using a rudimentary knowledge of arcane theory to create a temporary piece of ammunition. You gain the (feat: Conjure Bullet) action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificGunslingersWay(Guid.Parse("697c207c-dcca-4979-a5c5-80aa8e69c75a"), GunslingerWays.Instances.WayOfTheSpellshot.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73d7129d-da3f-4919-b048-308baf9d15f2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
