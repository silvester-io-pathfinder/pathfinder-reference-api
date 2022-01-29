using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShieldOfReckoning : Template
    {
        public static readonly Guid ID = Guid.Parse("817919c3-da9a-4a18-894d-5d7ef5ef3878");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shield of Reckoning",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A foe's attack against an ally matches the trigger for both your Shield Block reaction and your champion's reaction.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("63354352-363e-44fa-9995-60ada027888b"), Type = TextBlockType.Text, Text = $"When you shield your ally against an attack, you call upon your power to protect your ally further. You use the {ToMarkdownLink<Models.Entities.Feat>("Shield Block", Feats.Instances.ShieldBlock.ID)} reaction to prevent damage to an ally and also use your champion's reaction against the foe that attacked your ally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e8619c6c-3946-4aec-8222-d8fa281dd4a0"), Feats.Instances.ChampionsReaction.ID);
            builder.HaveSpecificDivineAlly(Guid.Parse("e7a431bf-1153-4613-89bf-8f0ee527e3ef"), DivineAllies.Instances.Shield.ID);
            builder.HaveSpecificTenet(Guid.Parse("6800d695-a7eb-4311-ba07-5f5a748d210f"), Tenets.Instances.Good.ID);
            builder.HaveSpecificFeat(Guid.Parse("ddeca8eb-fda6-40c6-ac3d-542b47477939"), Feats.Instances.ShieldWarden.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcc945a7-d630-4ed5-8b0f-bdc54ba9e48d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
